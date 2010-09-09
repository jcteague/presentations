public class Wallet
{
	double Cash{get;set;}
	public double Withdraw(double amount){
		if(Cash < amount)
			throw new InsufficientFundsException();
		Cash -= amount;
		return amount;
	}
}

public class Customer
{
	Wallet Wallet{get;set;}
	public double Pay(double amount)
	{
		Wallet.Withdraw(amount);
	}
}

public class Paperboy
{
	public double AmountCollected{get;set}
	public void CollectMoney(Customer customer, double amount)
	{
		AmountCollected += customer.Pay(amount);
	}
}