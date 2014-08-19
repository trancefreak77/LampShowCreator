using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LampShowCreator {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void CreateStatesBtn_Click(object sender, EventArgs e) {
      // Split the text by \n
      string[] textLines = richTextBox1.Text.Split('\n');
      Dictionary<string, List<byte>> lampTimeDictionary = new Dictionary<string, List<byte>>();

      // Get the identifier (Lamp or Coil).
      foreach (var textLine in textLines) {
        bool isLamp = true;
        int colonIndex = textLine.IndexOf(':');
        if (colonIndex >= 0) {
          // We found an identifier.
          if (textLine.Substring(0, colonIndex).ToLower() == "coil") {
            // It's a coil.
            isLamp = false;
          }
        } else {
          colonIndex = 0;
        }

        // Get name of lamp.
        int pipeIndex = textLine.IndexOf('|');
        if (pipeIndex < 0) {
          // Not found, ignore this line.
          continue;
        }

        string lampName = textLine.Substring(colonIndex + 1, (pipeIndex - colonIndex - 1)).Replace("\t", "");
        if (!lampTimeDictionary.ContainsKey(lampName)) {
          lampTimeDictionary.Add(lampName, new List<byte>());
        }

        // Now go through timeline...
        for (int i = 0; i < (textLine.Length - pipeIndex - 2); i++) {
          if (textLine[pipeIndex + 2 + i] == '.') {
            lampTimeDictionary[lampName].Add(1);
          } else {
            lampTimeDictionary[lampName].Add(0);
          }
        }
      }

      // Now we have parsed the lamp show text lines.
      // Loop through each 1/32 time point and find out the
      // differences between the previous one. Only create
      // states for different lamp states.
      // Initialize lamp states.
      Dictionary<string, byte> currentLampStates = new Dictionary<string, byte>();
      foreach (var lampKey in lampTimeDictionary.Keys) {
        if (!currentLampStates.ContainsKey(lampKey)) {
          currentLampStates.Add(lampKey, 255);  // 255 means not initialized.
        }
      }

      int currentState = 1;
      string stateMachineString = "switch (_currentState) {\n";

      for (int column = 0; column < 100; column ++) {
        stateMachineString += "  case " + currentState + ":\n";
        foreach (var lampKey in lampTimeDictionary.Keys) {
          if (lampTimeDictionary[lampKey][column] != currentLampStates[lampKey]) {
            currentLampStates[lampKey] = lampTimeDictionary[lampKey][column];
            stateMachineString = string.Concat(stateMachineString, "    lamps[" + lampKey + "] = " + currentLampStates[lampKey] + ";\n");
          }
        }

        stateMachineString += "    _currentState++;\n    break;\n";
        currentState++;
      }

      MessageBox.Show(stateMachineString);
    }

  }
}
