using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Use | as a separator
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }

        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _response = parts[2]
                };
                _entries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}
