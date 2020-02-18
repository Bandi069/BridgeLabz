
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using OOPS.AddressBook;

namespace OOPS.CommercialDataProcessing
{
    public interface IStockAccountInterface
    {
        /// <summary>
        /// declaration of Account create method.
        /// </summary>
        void StockAcountCreate();

        /// <summary>
        /// declaration of Account create method.
        /// </summary>
        /// <returns>it return total share of user</returns>
        double ValueOf();

        /// <summary>
        /// declaration of Sell Method
        /// </summary>
        void Save();

        /// <summary>
        /// declaration of report method.
        /// </summary>
        void PrintReport();
    }
    /// <summary>
    /// StockTransaction Interface
    /// </summary>
    public interface IStockTarnsaction
    {
        /// <summary>
        /// declaration of buy share method.
        /// </summary>
        void Buy();

        /// <summary>
        /// declaration of buy share method.
        /// </summary>
        void Sell();
    }
    /// <summary>
    /// This is Stock class which implements Stock Account Interface.
    /// </summary>
    public class StockAccount : IStockAccountInterface, IStockTarnsaction
    {
        /// <summary>
        /// This method create the account of multiple users.
        /// </summary>
        public void StockAcountCreate()
        {
            ////this line take the path of user details file.
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

            ////here create number of users.
            Console.WriteLine("How Many User Want To Create Account ");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());

            ////this is user array which stored multiple user object.
            UserDetails[] user = new UserDetails[numberOfUser];

            ////this for loop create the memory to multiple users.
            for (int i = 0; i < numberOfUser; i++)
            {
                user[i] = new UserDetails();
                user[i].UseGetInput();
            }

            ////this line create list of user details type.
            List<UserDetails> writeUser = new List<UserDetails>();

            ////this for loop used to add multiple user into list of user details.
            for (int i = 0; i < numberOfUser; i++)
            {
                writeUser.Add(user[i]);
            }

            ////this line convert the object into string.
            string jsonStock = JsonConvert.SerializeObject(user, Formatting.Indented);

            ////Stream Writer is used for to write into file. 
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
        }

        /// <summary>
        /// this method return all number of share buy by user.
        /// </summary>
        /// <returns>it return total share</returns>
        public double ValueOf()
        {
            ////this line take the path of user details file.
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

            double availableShare = 0.0;
            string json = File.ReadAllText(path);

            StreamReader streamReader = new StreamReader(path);

            ////this line read start to end text from file.
            string readString = streamReader.ReadToEnd();
            streamReader.Close();

            ////it create list of user object from given string.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

            ////here user must provide the user name to check account.
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();

            int size = userList.Count();
            int count = 1;
            ////this loop take the one by one object from list of user object.
            foreach (UserDetails objStock in userList)
            {
                ////this string retrive the name of user.
                string newUserUpdate = objStock.accountHolderName;
                count++;

                ////if condition check the user is available or not.
                if (newUserUpdate.Equals(accountHolderName))
                {
                    availableShare = objStock.noOfShareBuyUser;
                    break;
                }

                if (count > size)
                {
                    Console.WriteLine("Invalide User Name");
                    break;
                }
            }

            if (availableShare != 0)
            {
                return availableShare;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// This method show the account of particular user.
        /// </summary>
        public void ShowMyAccount()
        {
            ////this line take the path of user details file.
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

            ////here read all text from file and stored into json string.
            string json = File.ReadAllText(path);

            ////stream reader read the file which path we provided.
            StreamReader streamReader = new StreamReader(path);

            ////this line read start to end text from file.
            string readString = streamReader.ReadToEnd();
            streamReader.Close();

            ////it create list of user object from given string.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

           
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();

            int size = userList.Count();
            int count = 1;
            ////this loop take the one by one object from list of user object.
            foreach (UserDetails objStock in userList)
            {
                ////this string retrive the name of user.
                string newUserUpdate = objStock.accountHolderName;
                count++;


                if (newUserUpdate.Equals(accountHolderName))
                {
                    Console.WriteLine("UserName : " + newUserUpdate);
                    Console.WriteLine("Total Share : " + objStock.noOfShareBuyUser);
                    Console.WriteLine("Total Amount : " + objStock.totalAmountAccountHolder);
                    break;
                }
                if (count > size)
                {
                    Console.WriteLine("Invalid User Name");
                    break;
                }
            }
        }

        public void Buy()
        {
            int availableShareOfStock = 0;
            int previousShare = 0;
            double sharePrice = 0.0;
            ////this variable use to check user is valide or not to buy share .
            double valideToBuy = 0.0;
            double totalAmountOfUser = 0;
            string name = string.Empty;
            try
            {
                string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

                string json = File.ReadAllText(path);

                ////stream reader read the file which path we provided.
                StreamReader streamReader = new StreamReader(path);

                ////this line read start to end text from file.
                string readString = streamReader.ReadToEnd();
                streamReader.Close();

                ////this variable use to take name share .
                string userName = string.Empty;
                Console.WriteLine("Enter Your UserName");
                string accountHolderName = Console.ReadLine();

                ////it create list of user object from given string.
                List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

                ////here user must provide the user name to check account.

                int size = userList.Count();
                int count = 1;
                ////this loop take the one by one object from list of user object.
                foreach (UserDetails objStock in userList)
                {
                    ////this string retrive the name of user.
                    string newUserUpdate = objStock.accountHolderName;
                    count++;

                    ////if condition check the user is available or not.
                    if (newUserUpdate.Equals(accountHolderName))
                    {
                        GetDetails();
                        break;
                    }
                    if (count > size)
                    {
                        Console.WriteLine("Invalide User Name");
                        break;
                    }
                }
                Console.WriteLine("Enter Stock Name To Buy Share");
                string stockName = Console.ReadLine();

                ////here user enter how many share he want to buy
                Console.WriteLine("How Many Share You Want To Buy ");
                int numberOfShareBuy = Convert.ToInt32(Console.ReadLine());

                string readPath = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
                var json2 = File.ReadAllText(readPath);
                var jsonObject = JObject.Parse(json2);
                string jsonPath = File.ReadAllText(readPath);
                dynamic jsonObj = JsonConvert.DeserializeObject(jsonPath);

                int i;
                for (i = 0; i < 5; i++)
                {
                    string retriveName = jsonObj["stockReport"][i]["stockName"];

                    ////this if condition check stock name is available in file or not.
                    if (retriveName.Equals(stockName))
                    {
                        sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                        availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                        name = jsonObj["stockReport"][i]["stockName"];
                        break;
                    }
                }

                ////this code use to update where user want to buy the share with specified file path.
                StreamReader streamReaderUser = new StreamReader(@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json");
                string readUserFile = streamReaderUser.ReadToEnd();
                streamReaderUser.Close();

                ////this line create list of object.
                List<UserDetails> userList2 = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);

                int size2 = userList.Count();
                int count2 = 1;
                ////this use to check the particular user for update.
                foreach (UserDetails objUser in userList)
                {
                    ////userName stored the current user name.
                    userName = objUser.accountHolderName;
                    count2++;
                    ////it check user Name is Valide Or not.
                    if (userName.Equals(accountHolderName))
                    {
                        totalAmountOfUser = objUser.totalAmountAccountHolder;
                        previousShare = objUser.noOfShareBuyUser + numberOfShareBuy;
                        valideToBuy = numberOfShareBuy * sharePrice;

                        ////if available balance of user is greater than buying share then true this condition.
                        if (totalAmountOfUser >= valideToBuy)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You Dont Have Sufficient Dollers");
                        }
                    }
                }

                ////After Eligible to buy share 
                ////update the available share of company.
                availableShareOfStock = availableShareOfStock - numberOfShareBuy;
                totalAmountOfUser = totalAmountOfUser - valideToBuy;

                ////this method Update the Campany Shares 
                this.Save(name, availableShareOfStock, totalAmountOfUser);

                ////this method update user Account
                this.Save(userName, totalAmountOfUser, previousShare);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valide Input " + e);
            }
        }

        /// <summary>
        /// this method sell the share by user.
        /// </summary>
        public void Sell()
        {
            ////this variable use to take share price of campany.
            double sharePrice = 0.0;

            ////this variable use to check user is valide or not to buy share .
            double newAmountOfUser = 0.0;

            ////this variable use to check total amount of user.
            double totalAmountOfUser = 0;

            ////this variable use to take name of campany.
            string name = string.Empty;
            try
            {
                ////this line take the path of user details file.
                string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

                ////here read all text from file and stored into json string.
                string json = File.ReadAllText(path);

                ////stream reader read the file which path we provided.
                StreamReader streamReader = new StreamReader(path);

                ////this line read start to end text from file.
                string readString = streamReader.ReadToEnd();
                streamReader.Close();

                ////this variable use to take name share .
                string userName = string.Empty;
                Console.WriteLine("Enter Your UserName");
                string accountHolderName = Console.ReadLine();
                bool isValide = false;

                ////it create list of user object from given string.
                List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

                ////here user must provide the user name to check account.

                int size = userList.Count();
                int count = 1;
                ////this loop take the one by one object from list of user object.
                foreach (UserDetails objStock in userList)
                {
                    ////this string retrive the name of user.
                    string newUserUpdate = objStock.accountHolderName;
                    count++;

                    ////if condition check the user is available or not.
                    if (newUserUpdate.Equals(accountHolderName))
                    {
                        //// GetDetails();
                        isValide = true;
                        break;
                    }

                    if (count > size)
                    {
                        Console.WriteLine("Invalide User Name");
                        break;
                    }
                }

                if (isValide)
                {
                    ////this method display Stock Report.
                    ////here user enter whichever stock he want to buy.
                    Console.WriteLine("Enter Stock Name To Sell Share");
                    string stockName = Console.ReadLine();

                    ////here user enter how many share he want to buy
                    Console.WriteLine("How Many Share You Want To Sell ");
                    int numberOfShareSell = Convert.ToInt32(Console.ReadLine());

                    ////This code get the stock details to update stock file records.
                    string readPath = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
                    var json2 = File.ReadAllText(readPath);
                    var jsonObject = JObject.Parse(json2);

                    //// read the file here.
                    string jsonPath = File.ReadAllText(readPath);

                    ////it dynamically create object.
                    dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonPath);

                    ////this loop use to take share price of particular stock.
                    int i;
                    for (i = 0; i < 5; i++)
                    {
                        string retriveName = jsonObj["stockReport"][i]["stockName"];

                        ////this if condition check stock name is available in file or not.
                        if (retriveName.Equals(stockName))
                        {
                            sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                            //// availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                            ////  name = jsonObj["stockReport"][i]["stockName"];
                            break;
                        }
                    }

                    ////this code use to update where user want to buy the share with specified file path.
                    StreamReader streamReaderUser = new StreamReader(@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json");
                    string readUserFile = streamReaderUser.ReadToEnd();
                    streamReaderUser.Close();

                    ////this line create list of object.
                    List<UserDetails> userList2 = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);
                    int totalShareUser = 0;
                    int size2 = userList.Count();
                    int count2 = 1;
                    ////this use to check the particular user for update.
                    foreach (UserDetails objUser in userList)
                    {
                        ////userName stored the current user name.
                        userName = objUser.accountHolderName;
                        count2++;
                        ////it check user Name is Valide Or not.
                        if (userName.Equals(accountHolderName))
                        {
                            totalAmountOfUser = objUser.totalAmountAccountHolder;
                            totalShareUser = objUser.noOfShareBuyUser;
                            ////   previousShare = objUser.noOfShareBuyUser + numberOfShareBuy;
                            newAmountOfUser = numberOfShareSell * sharePrice;

                            ////if available balance of user is greater than buying share then true this condition.
                            if (totalShareUser > 0)
                            {
                                totalAmountOfUser = totalAmountOfUser + newAmountOfUser;
                                totalShareUser = totalShareUser - numberOfShareSell;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You Dont Have Sufficient Shares");
                            }
                        }
                    }
                    ////this method update user Account
                    this.Save(userName, totalAmountOfUser, totalShareUser);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Valide Input " + e);
            }
        }

        /// <summary>
        /// this print method show all reports of stock report.
        /// </summary>
        public void PrintReport()
        {
            ////this method print stock report.
            GetDetails();
        }

        /// <summary>
        /// This is empty method.
        /// </summary>
        public void Save()
        {
        }

        /// <summary>
        /// this method get all details of stock file or report data.
        /// </summary>
        public static void GetDetails()
        {
            ////this file path used to read the file.
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";

            ////read all text start to end of file.
            var json = File.ReadAllText(path);
            var jsonObject = JObject.Parse(json);

            ////it create json array of object.
            JArray stockArrary = (JArray)jsonObject["stockReport"];

            ////if stock array not null then its true condition
            if (stockArrary != null)
            {
                ////this for loop print all record of stock details.
                foreach (var objStock in stockArrary)
                {

                    Console.Write("\t Stock Name: " + objStock["stockName"].ToString());
                    Console.Write("\t Total Share: " + objStock["noOfShare"]);
                    Console.Write("\t Share Price: " + objStock["sharePrice"] + "\n\n");
                }
            }
        }

        /// <summary>
        ///  Save Details 
        /// </summary>
        /// <param name="nameOfStock"></param>
        /// <param name="availableShareOfStock"></param>
        /// <param name="totalAmountOfUser"></param>
        public void Save(string nameOfStock, int availableShareOfStock, double totalAmountOfUser)
        {
            ////this file path used to read the file.
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
            string json = File.ReadAllText(path);

            ////it dynamically create object.
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            int index;

            ////this loop use to take share price of particular stock.
            for (index = 0; index < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];

                ////it check stock name is valide or not.
                if (retriveName.Equals(nameOfStock))
                {
                    jsonObj["stockReport"][index]["noOfShare"] = availableShareOfStock;
                    break;
                }
            }

            ////it write the record into file .
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);
        }

        /// <summary>
        /// this method used to update user account data.
        /// </summary>
        /// <param name="userName">it take user name</param>
        /// <param name="userTotalAmount">it take total amount</param>
        /// <param name="currentShare">it take current share</param>
        public void Save(string userName, double userTotalAmount, int currentShare)
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";
            string json = File.ReadAllText(path);

            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            

            ////create list of object of user details type.
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);

            foreach (UserDetails objStock in userList)
            {
                string newUserUpdate = objStock.accountHolderName;
                if (newUserUpdate.Equals(userName))
                {
                    double totalAmount = userTotalAmount;
                    userList.Remove(objStock);
                    userList.Add(new UserDetails { accountHolderName = objStock.accountHolderName, totalAmountAccountHolder = totalAmount, noOfShareBuyUser = currentShare });
                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    
                    StreamWriter streamWriter = new StreamWriter(@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json");
                    streamWriter.WriteLine(updateUserData);
                   
                    break;
                }
            }
        }
    }
}
