using System.Text.RegularExpressions;

namespace ClimateMonitor.Services;

public class FirmewareValidatorService
{
    public static bool IsValidVersion(string version)
    {
        // Define the pattern for a valid version: INTEGER.INTEGER.INTEGER-STRING
        string pattern = @"^\d+(\.\d+){2}(-[a-zA-Z0-9]+)?$";

        // Use regular expression to validate the version string
        return Regex.IsMatch(version, pattern);
    }

    public bool ValidateFirmware(string version) 
        => IsValidVersion(version);
}
