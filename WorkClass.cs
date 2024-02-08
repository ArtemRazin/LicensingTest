using System;

internal class WorkClass
{

    public void Work()
    {
        string key = Console.ReadLine();
        ArmDot.Client.Api.PutKey(key);
        string state;
        switch (ArmDot.Client.Api.GetLicenseState())
        {
            case ArmDot.Client.Api.LicenseKeyState.Valid:
                {
                    state = "valid";
                    break;
                }
            case ArmDot.Client.Api.LicenseKeyState.Blocked:
                {
                    state = "blocked";
                    break;
                }
            case ArmDot.Client.Api.LicenseKeyState.Expired:
                {
                    state = "expired";
                    break;
                }
            case ArmDot.Client.Api.LicenseKeyState.MaximumBuildDateExpired:
                {
                    state = "maximum build date expired";
                    break;
                }
            case ArmDot.Client.Api.LicenseKeyState.BadHardwareId:
                {
                    state = "bad hardware id";
                    break;
                }
            case ArmDot.Client.Api.LicenseKeyState.Invalid:
            default:
                {
                    state = "invalid";
                    break;
                }
        }
        Console.WriteLine(state);
    }
}