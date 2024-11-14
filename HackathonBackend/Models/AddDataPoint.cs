using HackathonBackend.Models;

using System;
using System.Collections.Generic;
using System.Linq;

public class EnergyMonitor
{
    private readonly List<UserInfo> _dataPoints;
    private bool _isAboveThreshold; // Tracks if the last point was above the threshold

    public EnergyMonitor()
    {
        _dataPoints = new List<UserInfo>();
        _isAboveThreshold = false; // Initialize as not above threshold
    }

    public void AddDataPoint(UserInfo dataPoint)
    {
        _dataPoints.Add(dataPoint);
        double average = CalculateAverageActiveEnergyOutlet();
        double threshold = average * 1.10; // 10% above average

        // Check if the current data point is above the threshold
        if (dataPoint.ActiveEnergyOutlet > threshold)
        {
            // Notify only if previously not above the threshold
            if (!_isAboveThreshold)
            {
                NotifyAboveThreshold(dataPoint);
                _isAboveThreshold = true; // Set flag to true to avoid repetitive notifications
            }
        }
        else
        {
            // Reset the flag when it drops below threshold
            _isAboveThreshold = false;
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


// The average value of the active_energy_outlet column in the one-week dataset is approximately 0.0963. according to chat. 
// So if it wont work the thresshold should be set to adding 10% gives approximately 0.1059.