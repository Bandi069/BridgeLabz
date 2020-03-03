// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using OOPS.AddressBook;
    public interface IStockAccountInterface
    {
        /// <summary>
        /// This is  Account create method.
        /// </summary>
        void StockAcountCreate();

        /// <summary>
        /// This is Account create method.
        /// </summary>
        /// <returns>it return total share of user</returns>
        double ValueOf();

        /// <summary>
        /// This is sell method
        /// </summary>
        void Save();

        /// <summary>
        /// this is print report method.
        /// </summary>
        void PrintReport();
    }
    /// <summary>
    /// This is interface of StockTransaction 
    /// </summary>
    public interface IStockTarnsaction
    {
        /// <summary>
        /// This is buy share method.
        /// </summary>
        void Buy();

        /// <summary>
        /// This  buy share method.
        /// </summary>
        void Sell();
    }
    /// <summary>
    /// This is Stock Account class 
    /// This Implements Stock Account Interface.
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

            Console.WriteLine("Number  To Create stock Account ");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());

            UserDetails[] user = new UserDetails[numberOfUser];
            for (int i = 0; i < numberOfUser; i++)
            {
                user[i] = new UserDetails();
                user[i].UseGetInput();
            }

            List<UserDetails> writeUser = new List<UserDetails>();
            for (int i = 0; i < numberOfUser; i++)
            {
                writeUser.Add(user[i]);
            }
            string jsonStock = JsonConvert.SerializeObject(user, Formatting.Indented);
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
        }
        /// <summary>
        /// This method return all number of shares buy by user.
        /// </summary>
        /// <returns value="availableShare"></returns>
        public double ValueOf()
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";
            double availableShare = 0.0;
            string json = File.ReadAllText(path);
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();

            int size = userList.Count();
            int count = 1;
            foreach (UserDetails objStock in userList)
            {
                string newUserUpdate = objStock.accountHolderName;
                count++;
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
        /// This method show details of  stock accountuser.
        /// </summary>
        public void ShowMyAccount()
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";
            string json = File.ReadAllText(path);
            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
            streamReader.Close();
            List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);
            Console.WriteLine("Enter Your UserName");
            string accountHolderName = Console.ReadLine();
            int size = userList.Count();
            int count = 1;
            foreach (UserDetails objStock in userList)
            {
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
        /// <summary>
        /// This is buy method
        /// </summary>
        public void Buy()
        {
            int availableShareOfStock = 0;
            int previousShare = 0;
            double sharePrice = 0.0;
            double valideToBuy = 0.0;
            double totalAmountOfUser = 0;
            string name = string.Empty;
            try
            {
                string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";

                string json = File.ReadAllText(path);
                StreamReader streamReader = new StreamReader(path);
                string readString = streamReader.ReadToEnd();
                streamReader.Close();
                string userName = string.Empty;
                Console.WriteLine("Enter Stock Account UserName");
                string accountHolderName = Console.ReadLine();
                List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);
                int size = userList.Count();
                int count = 1;
                foreach (UserDetails objStock in userList)
                {
                    string newUserUpdate = objStock.accountHolderName;
                    count++;
                    if (newUserUpdate.Equals(accountHolderName))
                    {
                        GetDetails();
                        break;
                    }
                    if (count > size)
                    {
                        Console.WriteLine("Invalide Stock Account User name");
                        break;
                    }
                }
                Console.WriteLine("Enter Stock Name To Buy");
                string stockName = Console.ReadLine();
                Console.WriteLine("No of Share To Buy ");
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
                    if (retriveName.Equals(stockName))
                    {
                        sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                        availableShareOfStock = jsonObj["stockReport"][i]["noOfShare"];
                        name = jsonObj["stockReport"][i]["stockName"];
                        break;
                    }
                }
                StreamReader streamReaderUser = new StreamReader(@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json");
                string readUserFile = streamReaderUser.ReadToEnd();
                streamReaderUser.Close();
                List<UserDetails> userList2 = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);

                int size2 = userList.Count();
                int count2 = 1;
                foreach (UserDetails objUser in userList)
                {
                    userName = objUser.accountHolderName;
                    count2++;
                    if (userName.Equals(accountHolderName))
                    {
                        totalAmountOfUser = objUser.totalAmountAccountHolder;
                        previousShare = objUser.noOfShareBuyUser + numberOfShareBuy;
                        valideToBuy = numberOfShareBuy * sharePrice;
                        if (totalAmountOfUser >= valideToBuy)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Amount");
                        }
                    }
                }
                availableShareOfStock = availableShareOfStock - numberOfShareBuy;
                totalAmountOfUser = totalAmountOfUser - valideToBuy;
                this.Save(name, availableShareOfStock, totalAmountOfUser);
                this.Save(userName, totalAmountOfUser, previousShare);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs " + e);
            }
        }

        /// <summary>
        /// this method sell the share by user.
        /// </summary>
        public void Sell()
        {
            double sharePrice = 0.0;
            double newAmountOfUser = 0.0;
            double totalAmountOfUser = 0;
            string name = string.Empty;
            try
            {
                string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";
                string json = File.ReadAllText(path);
                StreamReader streamReader = new StreamReader(path);
                string readString = streamReader.ReadToEnd();
                streamReader.Close();
                string userName = string.Empty;
                Console.WriteLine("Enter Stock User Name");
                string accountHolderName = Console.ReadLine();
                bool isValide = false;
                List<UserDetails> userList = JsonConvert.DeserializeObject<List<UserDetails>>(readString);
                int size = userList.Count();
                int count = 1;
                foreach (UserDetails objStock in userList)
                {
                    string newUserUpdate = objStock.accountHolderName;
                    count++;
                    if (newUserUpdate.Equals(accountHolderName))
                    {
                        GetDetails();
                        isValide = true;
                        break;
                    }

                    if (count > size)
                    {
                        Console.WriteLine("Invalid Stock user Name");
                        break;
                    }
                }

                if (isValide)
                {

                    Console.WriteLine("Enter Stock Name To Sell Share");
                    string stockName = Console.ReadLine();
                    Console.WriteLine("No of Shares to Sell ");
                    int numberOfShareSell = int.Parse(Console.ReadLine());
                    string readPath = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
                    var json2 = File.ReadAllText(readPath);
                    var jsonObject = JObject.Parse(json2);
                    string jsonPath = File.ReadAllText(readPath);
                    dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonPath);
                    int i;
                    for (i = 0; i < 5; i++)
                    {
                        string retriveName = jsonObj["stockReport"][i]["stockName"];
                        if (retriveName.Equals(stockName))
                        {
                            sharePrice = jsonObj["stockReport"][i]["sharePrice"];
                        }
                    }
                    StreamReader streamReaderUser = new StreamReader(@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json");
                    string readUserFile = streamReaderUser.ReadToEnd();
                    streamReaderUser.Close();
                    List<UserDetails> userList2 = JsonConvert.DeserializeObject<List<UserDetails>>(readUserFile);
                    int totalShareUser = 0;
                    int size2 = userList.Count();
                    int count2 = 1;
                    foreach (UserDetails objUser in userList)
                    {
                        userName = objUser.accountHolderName;
                        count2++;
                        if (userName.Equals(accountHolderName))
                        {
                            totalAmountOfUser = objUser.totalAmountAccountHolder;
                            totalShareUser = objUser.noOfShareBuyUser;
                            newAmountOfUser = numberOfShareSell * sharePrice;
                            if (totalShareUser > 0)
                            {
                                totalAmountOfUser = totalAmountOfUser + newAmountOfUser;
                                totalShareUser = totalShareUser - numberOfShareSell;
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Shares to sell");
                            }
                        }
                    }
                    this.Save(userName, totalAmountOfUser, totalShareUser);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ception occurs" + e.Message);
            }
        }

        /// <summary>
        /// This is to print all reports
        /// </summary>
        public void PrintReport()
        {
            GetDetails();//// For get details
        }

        /// <summary>
        /// This method to get all details of stock
        /// </summary>
        public static void GetDetails()
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
            var json = File.ReadAllText(path);
            var jsonObject = JObject.Parse(json);
            JArray stockArrary = (JArray)jsonObject["stockReport"];
            if (stockArrary != null)
            {
                foreach (var objStock in stockArrary)
                {
                    Console.Write(" Name of Stock : " + objStock["stockName"].ToString());
                    Console.Write(" Total Share: " + objStock["noOfShare"]);
                    Console.Write(" Share Price: " + objStock["sharePrice"]);
                }
            }
        }

        /// <summary>
        ///  This is Save Details Method 
        /// </summary>
        /// <param name="nameOfStock"></param>
        /// <param name="availableShareOfStock"></param>
        /// <param name="totalAmountOfUser"></param>
        public void Save(string nameOfStock, int availableShareOfStock, double totalAmountOfUser)
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\StockDetails.json";
            string json = File.ReadAllText(path);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            int index;
            for (index = 0; index < 5; i++)
            {
                string retriveName = jsonObj["stockReport"][i]["stockName"];
                if (retriveName.Equals(nameOfStock))
                {
                    jsonObj["stockReport"][index]["noOfShare"] = availableShareOfStock;
                    break;
                }
            }
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, output);
        }

        /// <summary>
        /// This is the method used to Save the StockAccount data.
        /// </summary>
        public void Save(string userName, double userTotalAmount, int currentShare)
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\CommercialDataProcessing\userDetail.json";
            string json = File.ReadAllText(path);

            StreamReader streamReader = new StreamReader(path);
            string readString = streamReader.ReadToEnd();
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
                }
            }
        }
    }
}
