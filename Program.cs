namespace TemplatePattern.Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User<string> user = new User<string>();
            user.ValueToSave = "Kostas";
            user.Save();

            List<string> recordsList = Record<string>.GetRecordList();

            user.ValueToSave = "Magda";
            user.Save();

            List<string> recordsList2 = Record<string>.GetRecordList();

            foreach(string record in recordsList2)
            {
                Console.WriteLine(record);
            }


        }
    }

}