using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeroAxisX;

public class MainForm : Form
{
    public MainForm()
    {
        Text = "0axisx — Minecraft Mod Maker";
        Width = 900;
        Height = 600;
        StartPosition = FormStartPosition.CenterScreen;

        var title = new Label
        {
            Text = "0axisx",
            Font = new Font("Segoe UI", 26, FontStyle.Bold),
            AutoSize = true,
            Left = 30,
            Top = 25
        };

        var subtitle = new Label
        {
            Text = "Minecraft Java + Bedrock Mod Maker",
            AutoSize = true,
            Left = 34,
            Top = 75
        };

        var javaButton = new Button
        {
            Text = "Java Edition",
            Left = 30,
            Top = 120,
            Width = 200,
            Height = 55
        };

        var bedrockButton = new Button
        {
            Text = "Bedrock Edition",
            Left = 250,
            Top = 120,
            Width = 200,
            Height = 55
        };

        var blockButton = new Button
        {
            Text = "Add Block",
            Left = 30,
            Top = 200,
            Width = 200,
            Height = 55
        };

        var itemButton = new Button
        {
            Text = "Add Item",
            Left = 250,
            Top = 200,
            Width = 200,
            Height = 55
        };

        var status = new Label
        {
            Text = "Ready.",
            AutoSize = true,
            Left = 30,
            Top = 290
        };

        javaButton.Click += (_, _) =>
            status.Text = "Java Edition selected.";

        bedrockButton.Click += (_, _) =>
            status.Text = "Bedrock Edition selected.";

        blockButton.Click += (_, _) =>
            status.Text = "Block creator selected.";

        itemButton.Click += (_, _) =>
            status.Text = "Item creator selected.";

        Controls.Add(title);
        Controls.Add(subtitle);
        Controls.Add(javaButton);
        Controls.Add(bedrockButton);
        Controls.Add(blockButton);
        Controls.Add(itemButton);
        Controls.Add(status);
    }
}

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}