namespace mis_221_pa_5_ncraig02
{
    public class ListingReport
    {
        Listing[] listings;

        public ListingReport(Listing[] listings){
            this.listings = listings;
        }

        public void PrintAllListingsFromFile(){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetLive() == true){
                    System.Console.WriteLine(listings[i].ToString());
                }
            }
        }
    }
}