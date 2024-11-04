namespace BlazorAssignment.Components.Pages
{
    public class Company
    {
        public Company(string companyName, string companyCatchphrase)
        {
            CompanyName = companyName;
            CompanyCatchphrase = companyCatchphrase;
        }
        public string CompanyName { get; set; }
        public string CompanyCatchphrase { get; set; }
    }
}