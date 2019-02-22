using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Serialization;

namespace leervolt
{

public partial class SelectChipDialog : Form
{
    public ChipConfiguratonData data;
    public List<ChipConfiguratonData> loadedChips = new List<ChipConfiguratonData>();

    private int roomTemperature = 25;
    private int meltingTime = 20;

    public SelectChipDialog()
    {
        InitializeComponent();
        updateChipFromTextboxes();
        saveChipToDisk();
        loadAllChipsFromDisk();

        StripLine stripline = new StripLine
        {
            Interval = 0,
            IntervalOffset = 0,
            BackColor = chipTemperatureGraph.Series["Temperatura de daño"].Color
        };

        chipTemperatureGraph.ChartAreas.First().AxisY.StripLines.Add(stripline);
    }

    public void saveChipToDisk()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ChipConfiguratonData));
        string documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string finalPath = documentsFolderPath + "/reballing_chips/" + data.Name + ".reballing";
        using (StreamWriter xmlFileStream = new StreamWriter(finalPath))
        {
            xmlSerializer.Serialize(xmlFileStream, data);
        }
    }

    private void updateChipFromTextboxes()
    {
        data = readTextBoxes();
    }

    private int safeIntParse(string intString)
    {
        if (intString.Length == 0 || intString.Any(x => x < '0' || x > '9')) return 0;
        return int.Parse(intString);
    }

    private ChipConfiguratonData readTextBoxes()
    {
        return new ChipConfiguratonData
        {
            Name = chipNameTextbox.Text,
            DamageTemperarure = safeIntParse(damageTemperatureTextbox.Text),
            SoakTemperature = safeIntParse(soakTemperatureTextbox.Text),
            ReflowTemperature = safeIntParse(reflowTemperatureTextbox.Text),
            PreheatDuration = safeIntParse(preheatDurationTextbox.Text) * 1000,
            SoakDuration = safeIntParse(soakDurationTextbox.Text) * 1000,
            ReflowDuration = safeIntParse(reflowDurationTextbox.Text) * 1000,
            CoolingDuration = safeIntParse(coolingDurationTextbox.Text) * 1000
        };
    }

    private void updateTextboxesFromChip()
    {
        chipNameTextbox.Text = data.Name;
        soakTemperatureTextbox.Text = data.SoakTemperature.ToString();
        reflowTemperatureTextbox.Text = data.ReflowTemperature.ToString();
        damageTemperatureTextbox.Text = data.DamageTemperarure.ToString();
        preheatDurationTextbox.Text = (data.PreheatDuration / 1000).ToString();
        soakDurationTextbox.Text = (data.SoakDuration / 1000).ToString();
        reflowDurationTextbox.Text = (data.ReflowDuration / 1000).ToString();
        coolingDurationTextbox.Text = (data.CoolingDuration / 1000).ToString();
    }

    private void loadAllChipsFromDisk()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ChipConfiguratonData));
        string documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var filePaths = Directory.GetFiles(documentsFolderPath + "/reballing_chips");
        loadedChips.Clear();

        foreach (var path in filePaths)
        {
            using (StreamReader xmlFileStream = new StreamReader(path))
            {
                var xmlReader = new XmlTextReader(xmlFileStream);
                if(xmlSerializer.CanDeserialize(xmlReader))
                    loadedChips.Add((ChipConfiguratonData)xmlSerializer.Deserialize(xmlReader));
            }
        }

        chipSelectionComboBox.Items.Clear();
        foreach (ChipConfiguratonData loadedData in loadedChips)
        {
            chipSelectionComboBox.Items.Add(loadedData.Name);
        }
    }

    private void updateDamageTemperatureLine(int damageTemperature)
    {
        chipTemperatureGraph.Series["Temperatura de daño"].Points.Clear();
        chipTemperatureGraph.Series["Temperatura de daño"].Points.AddY(damageTemperature);
        chipTemperatureGraph.ChartAreas.First().AxisY.StripLines.First().IntervalOffset = damageTemperature;
        chipTemperatureGraph.ChartAreas.First().AxisY.StripLines.First().StripWidth = 0.03 * (Math.Abs(damageTemperature) + 1);
    }

    private void updateTemperatureGraph()
    {
        var textBoxData = readTextBoxes();
        chipTemperatureGraph.Series["Temperatura"].Points.Clear();

        int time = 0;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, roomTemperature);

        time += textBoxData.PreheatDuration / 1000;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.SoakTemperature);
            
        time += textBoxData.SoakDuration / 1000;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.SoakTemperature);
        
        time += meltingTime;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.ReflowTemperature);

        time += textBoxData.ReflowDuration / 1000;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.ReflowTemperature);
            
        time += textBoxData.CoolingDuration / 1000;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, roomTemperature);
    }

    private void updateGraph()
    {
        updateDamageTemperatureLine(readTextBoxes().DamageTemperarure);
        updateTemperatureGraph();
    }

    private void updateGraphEventWrapper(object sender, EventArgs e)
    {
        updateGraph();
    }

    private void acceptButton_Click(object sender, EventArgs e)
    {
        updateChipFromTextboxes();
        this.Hide();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        updateChipFromTextboxes();
        saveChipToDisk();
        loadAllChipsFromDisk();
    }

    private void chipSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        data = loadedChips[chipSelectionComboBox.SelectedIndex];
        updateTextboxesFromChip();
    }

}

}
