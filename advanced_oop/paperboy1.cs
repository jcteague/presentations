public class Wallet
{
	double Cash{get;set;}
}

public class Customer
{
	Wallet Wallet{get;set;}
}

public class Paperboy
{
	public double AmountCollected{get;set}
	public void CollectMoney(Customer customer, double amount){
		if(customer.Wallet != null){
			if(customer.Wallet.Cash < amount)
				throw new InsufficientFundsException();
			customer.Wallet.Cash -= amount;
			AmountCollected += customer.Wallet.Cash;
		}
		
		
	}

}