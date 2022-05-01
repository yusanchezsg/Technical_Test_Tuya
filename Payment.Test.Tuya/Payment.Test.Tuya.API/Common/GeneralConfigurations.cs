namespace Payment.Test.Tuya.API.Common
{

    public class GeneralConfigurations : IGeneralConfigurations
    {
        public string RelativePath { get; set; }

        public string FileName { get; set; }

        public string SecrectKey { get; set; }
    }

    public interface IGeneralConfigurations
    {
        string RelativePath { get; set; }

        string FileName { get; set; }

        string SecrectKey { get; set; }

    }
}
