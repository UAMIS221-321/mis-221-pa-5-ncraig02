namespace mis_221_pa_5_ncraig02
{
    public class Reports
    {
         private string customerEmail;
        private string customerName;
        private int totalNumberOfSessions;
        private int revenue;

        public Reports(){

        }

        public Reports(string customerEmail, string customerNAme, int totalNumberOfSessions, int revenue){
            this.customerEmail = customerEmail;
            this.customerName = customerNAme;
            this.totalNumberOfSessions = totalNumberOfSessions;
            this.revenue = revenue;
        }

        public void SetCustomerEmail(string customerEmail){
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail(){
            return customerEmail;
        }
        public void SetCustomerName(string customerName){
            this.customerName = customerName;
        }

        public string GetCustomerName(){
            return customerName;
        }

        public void SetTotalNumberOfSessions(int totalNumberOfSessions){
            this.totalNumberOfSessions = totalNumberOfSessions;
        }
        public int GetTotalNumberOfSessions(int totalNumberOfSessions){
            return totalNumberOfSessions;
        }

        public void SetRevenue(int revenue){
            this.revenue = revenue;
        }
        public int GetRevenue(){
            return revenue;
        }

        public string ToFile(){
            return $"{customerEmail}#{customerName}#{totalNumberOfSessions}#{revenue}";
        }
    }
}