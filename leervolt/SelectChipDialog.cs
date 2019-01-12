using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace leervolt
{

public partial class SelectChipDialog : Form
{
    public ChipConfiguratonData data;
    public List<ChipConfiguratonData> loadedChips = new List<ChipConfiguratonData>();

    public SelectChipDialog()
    {
        InitializeComponent();
        updateChipFromTextboxes();
        saveChipToDisk();
        loadAllChipsFromDisk();
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
        data = new ChipConfiguratonData
        {
            Name = chipNameTextbox.Text,
            DamageTemperarure = damageTemperatureTextbox.Text,
            InitialTargetTemperature = initialTemperatureTextbox.Text,
            FirstPlateauTemperature = firstPlateauTemperatureTextbox.Text,
            SecondPlateauTemperature = secondPlateauTemperatureTextbox.Text,
            FirstPlateauDuration = firstPlateauDurationTextbox.Text,
            SecondPlateauDuration = secondPlateauDurationTextbox.Text
        };

    }

    private void updateTextboxesFromChip()
    {
        chipNameTextbox.Text = data.Name;
        initialTemperatureTextbox.Text = data.InitialTargetTemperature;
        firstPlateauTemperatureTextbox.Text = data.FirstPlateauTemperature;
        secondPlateauTemperatureTextbox.Text = data.SecondPlateauTemperature;
        damageTemperatureTextbox.Text = data.DamageTemperarure;
        firstPlateauDurationTextbox.Text = data.FirstPlateauDuration;
        secondPlateauDurationTextbox.Text = data.SecondPlateauDuration;
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

    private void updateGraph()
    {
        
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
