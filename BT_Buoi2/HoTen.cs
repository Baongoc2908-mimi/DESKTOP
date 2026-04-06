using System;
using System.Linq;

public class HoTen
{
    public string FullName { get; set; }

    public HoTen(string fullName)
    {
        FullName = fullName.Trim();
    }
    public string LayHoLot()
    {
        var parts = FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length <= 2) return "";
        return string.Join(" ", parts.Skip(1).Take(parts.Length - 2));
    }
    public string LayTen()
    {
        var parts = FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return parts.Length > 0 ? parts[parts.Length - 1] : "";
    }
    public int DemTu()
    {
        if (string.IsNullOrWhiteSpace(FullName)) return 0;
        var parts = FullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return parts.Length;
    }
    public string HoaDauTu()
    {
        var parts = FullName.ToLower()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1);
        }

        return string.Join(" ", parts);
    }
}