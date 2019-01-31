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

    private int roomTemperature = 30;
    private int preheatingTime = 1000;
    private int meltingTime = 500;
    private int coolingTime = 2000;

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

    private ChipConfiguratonData readTextBoxes()
    {
        return new ChipConfiguratonData
        {
            Name = chipNameTextbox.Text,
            DamageTemperarure = int.Parse(damageTemperatureTextbox.Text),
            InitialTargetTemperature = int.Parse(initialTemperatureTextbox.Text),
            FirstPlateauTemperature = int.Parse(firstPlateauTemperatureTextbox.Text),
            SecondPlateauTemperature = int.Parse(secondPlateauTemperatureTextbox.Text),
            FirstPlateauDuration = int.Parse(firstPlateauDurationTextbox.Text),
            SecondPlateauDuration = int.Parse(secondPlateauDurationTextbox.Text)
        };
        }

    private void updateTextboxesFromChip()
    {
        chipNameTextbox.Text = data.Name;
        initialTemperatureTextbox.Text = data.InitialTargetTemperature.ToString();
        firstPlateauTemperatureTextbox.Text = data.FirstPlateauTemperature.ToString();
        secondPlateauTemperatureTextbox.Text = data.SecondPlateauTemperature.ToString();
        damageTemperatureTextbox.Text = data.DamageTemperarure.ToString();
        firstPlateauDurationTextbox.Text = data.FirstPlateauDuration.ToString();
        secondPlateauDurationTextbox.Text = data.SecondPlateauDuration.ToString();
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

        time += preheatingTime;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.FirstPlateauTemperature);
            
        time += textBoxData.FirstPlateauDuration;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.FirstPlateauTemperature);
        
        time += meltingTime;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.SecondPlateauTemperature);

        time += textBoxData.SecondPlateauDuration;
        chipTemperatureGraph.Series["Temperatura"].Points.AddXY(time, textBoxData.SecondPlateauTemperature);
            
        time += coolingTime;
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
