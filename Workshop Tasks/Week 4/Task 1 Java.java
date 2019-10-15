class ATM {
	
// Create a new account for each user (Start back to the beginning)	
	Account acc=new Account();
	
	private float Balance;
	private float Withdraw;
	
// 	Get Pin once pin is set and displays message (if Pin is incorrect locks account)
	public String getPin()	
	{
		System.out.println("Your pin is", pin);
	}
		return pin;
	}
	
// Set Pin for Customer's bank account  	
	public void setPin()
	{
		System.out.println("Your Pin is set");		
	} 
		this.pin = pin;
	}
	
// Get Balance from bank Account (Mini Statement)	
	public float getBalance{
		{
			System.out.println("Your balance is", balance);
		}		
	    return balance;
	}	
  	
// Set Withdraw from user's bank account (Balance changes)	 	
	public void setWithdraw(float Withdraw) {
	    this.Withdraw = Withdraw;
	}
	
// Receive money from user's bank account (Balance changes)	
	public void getMoney() {
	    return getMoney
    }
	
// 	Change the deposit from balance
   public void changedeposit() {
	    this.changedeposit = changedeposit;
    }
	
	//  Dispalys ATM information for user	
	acc.print();
	acc.show();
}

class Health_Monitoring_System{
	
// Create a new user for each user (Start back to the beginning)		
	MonitoringSystem ms=new MonitoringSystem();
	
	private float heart_rate;
	private float breathing_rate;
	private float administering_medication;
	
// Collect Heart rate data and displays message
public String getHeartRate
	{
	  System.out.println("Your Heart Rate is", HeartRate);
	}
		return HeartRate;
	}
// Set Heart rate data to system
	public void setHeartRate() {
		this.GetHeart = GetHeart;
	}
// 	
	public getbreathing_rate(){		
	    return breathing_rate;
	}	
	
//  Dispalys Monitoring System for user
	ms.print();
	ms.show();
}

class  A_Mobile_Phone_Fitness_app{
	
// Login to app with different user					
    Newuser nu=new Newuser();

	private float recording_current_weight;
	private float calories_consumed;
	private float administering_medication;
	private float sports_undertake;
	private string suggesting_recipes_for_meals;
	
	
// gets current weight of user on the app	
	public String getrecording_current_weight(){
		return recording_current_weight;
	}
// sets current weight of user on the app and displays message
		public String setrecording_current_weight()		
		{
		System.out.println("Your ecording current weight is", recording_current_weight);
		} 			
		this.recording_current_weight = recording_current_weight;
	}
	
// get calories consumed on the app and displays message
	    public void getcalories_consumed()	
	    {
		System.out.println("Your calories_consumed", calories_consumed);
		} 
		return calories_consumed;
	}
	
// set calories consumed on the app	
	public void setcalories_consumed() {		
		this.calories_consumed = calories_consumed;
	}
	
// get administering medication on the app
	public float getadministering_medication {		
	    return administering_medication;
	}	  	
	
// Set the administering medication on the app
	public float setadministering_medication {		
	    this.getadministering_medication = getadministering_medication;
	}	  	
	
// Get the sports undertake	on the app
	public void getsports_undertake() {
	    this.sports_undertake = sports_undertake;
	}
	
// Set the suggesting recipes for meals on the app
	public void setWithdraw(string suggesting_recipes_for_meals) {
	    this.suggesting_recipes_for_meals = suggesting_recipes_for_meals;
	}
	
// Displays information for user on the app		
	nu.print();
	nu.show();
}
