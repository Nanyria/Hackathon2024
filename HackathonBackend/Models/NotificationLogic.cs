using System;
using System.Collections.Generic;
using System.Linq;
using HackathonBackend.Models;

public class EnergyMonitor
{
    private readonly List<UserInfo> _dataPoints;
    private bool _isAboveThreshold; // Tracks if the last point was above the threshold
    private readonly List<Appliance> _appliances;
    private readonly List<EnergyProfile> _energyProfiles;

    public EnergyMonitor(List<Appliance> appliances, List<EnergyProfile> energyProfiles)
    {
        _dataPoints = new List<UserInfo>();
        _isAboveThreshold = false; // Initialize as not above threshold
        _appliances = appliances;
        _energyProfiles = energyProfiles;
    }

    public void AddDataPoint(UserInfo dataPoint)
    {
        _dataPoints.Add(dataPoint);
        double average = CalculateAverageActiveEnergyOutlet();
        double threshold = average * 1.10; // 10% above average

        // Check if the current data point is above the threshold (spike detected)
        if (dataPoint.ActiveEnergyOutlet > threshold)
        {
            // Notify only if previously not above the threshold
            if (!_isAboveThreshold)
            {
                // If there are schedulable appliances in use, notify the user
                if (IsSchedulableApplianceRunning(dataPoint))
                {
                    NotifyAboveThreshold(dataPoint);
                }
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

    // Check if any schedulable appliances are in use when a spike is detected
    private bool IsSchedulableApplianceRunning(UserInfo dataPoint)
    {
        // Check existing profiles to see if any include a schedulable appliance
        foreach (var profile in _energyProfiles)
        {
            var hasSchedulableAppliance = profile.Appliances
                .Select(id => _appliances.FirstOrDefault(a => a.Appliances == id))
                .Any(a => a != null && a.IsSchedulable);

            if (hasSchedulableAppliance)
            {
                return true;
            }
        }
        return false;
    }

    private void NotifyAboveThreshold(UserInfo dataPoint)
    {
        // Logic to send a notification or update a graph
        Console.WriteLine($"Alert: ActiveEnergyOutlet is 10% above average! Value: {dataPoint.ActiveEnergyOutlet} at {dataPoint.AtDateTime}");

        // Option to add appliance to profile or select existing
        Console.WriteLine("Do you want to add a new appliance to the energy profile, or select an existing profile?");
    }
}
