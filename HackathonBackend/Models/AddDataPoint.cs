using HackathonBackend.Models;

using System;
using System.Collections.Generic;
using System.Linq;

public class EnergyMonitor
{
    private readonly List<UserInfo> _dataPoints;

    public EnergyMonitor()
    {
        _dataPoints = new List<UserInfo>();
    }

    public void AddDataPoint(UserInfo dataPoint)
    {
        _dataPoints.Add(dataPoint);
        double average = CalculateAverageActiveEnergyOutlet();
        double threshold = average * 1.10; // 10% above the average

        if (dataPoint.ActiveEnergyOutlet > threshold)
        {
            NotifyAboveThreshold(dataPoint);
        }
    }

    private double CalculateAverageActiveEnergyOutlet()
    {
        if (_dataPoints.Count == 0) return 0;
        return _dataPoints.Average(dp => dp.ActiveEnergyOutlet);
    }

    private void NotifyAboveThreshold(UserInfo dataPoint)
    {
        // Logic to send a notification or update a graph
        Console.WriteLine($"Alert: ActiveEnergyOutlet is 10% above average! Value: {dataPoint.ActiveEnergyOutlet} at {dataPoint.AtDateTime}");
        
    }
}
