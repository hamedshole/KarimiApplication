using System;

namespace KarimiApp.Model
{
    public class TransactionEntryModel
    {


        public int Id { get; set; }
        public string TransactionType { get; set; }
        public string Item { get; set; }
        public int ItemId { get; set; }
        public long BuyPrice { get; set; }
        public long SellPrice { get; set; }
        public decimal Amount { get; set; }
           
        public string Description { get; set; }

        public TransactionEntryModel()
        {

        }

        public TransactionEntryModel(decimal amount, string transactionType, string item, long buyPrice)
        {
            this.Amount = amount;
            this.TransactionType = transactionType;
            Item = item;
            BuyPrice = buyPrice;
        }

        public void ChangeTransactionType(string transactionType)
        {
            this.TransactionType = transactionType;
        }
        public void AddAmount()
        {
            this.Amount++;
        }
        public TransactionEntryModel(int id,int itemId, string transactionType, string item, long buyprice,long sellprice, decimal amount, string description)
        {
            Id = id;
            this.ItemId = itemId;
            this.TransactionType = transactionType;
            Item = item;
            BuyPrice = buyprice;
            sellprice = buyprice;
            this.Amount = amount;
            Description = description;
        }

        public TransactionEntryModel(decimal amount, long sellprice, string item,int itemId)
        {
            this.ItemId = itemId;
            this.Amount = amount;
            SellPrice = sellprice;
            this.Item = item;
        }

        public TransactionEntryModel(string item,int itemId, string transactionType, long sellprice, int amount)
        {
            Item = item;
            this.ItemId = itemId;
            TransactionType = transactionType;
            SellPrice = sellprice;
            Amount = amount;
        }
    }
}
