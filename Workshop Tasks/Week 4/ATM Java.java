class ATM {
// Create a new account for each user (Start back to the beginning)	
	Account acc=new Account();
	
	private float Balance;
	private float Withdraw;
	
// 	Get Pin once pin is set (if Pin is incorrect locks account)
	public String getPin(){
		return pin;
	}
// Set Pin for Customer's bank account  	
	public void setPin() {
		this.pin = pin;
	}
// Get Balance from bank Account (Mini Statement)	
	public float getBalance(){		
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
	
	MonitoringSystem ms=new MonitoringSystem();
	
	private float heart_rate;
	private float breathing_rate;
	private float administering_medication;
	
	
// Collect Heart rate data
	public String getHeartRate(){
		return GetHeart;
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
				
    Appuser au=new Appuser();

	private float recording_current_weight;
	private float calories_consumed;
	private float administering_medication;
	private float sports_undertake;
	private string suggesting_recipes_for_meals;
	
	
// gets current weight of user on the app	
	public String getrecording_current_weight(){
		return recording_current_weight;
	}
// 	sets current weight of user on the app
		public String setrecording_current_weight() {			
		this.recording_current_weight = recording_current_weight;
	}
	
// get calories consumed on the app
	public void getcalories_consumed() {
		return calories_consumed;
	}
// set calories consumed on the app	
	public void setcalories_consumed() {		
		this.calories_consumed = calories_consumed;
	}
// get administering medication on the app
	public float getadministering_medication{		
	    return breathing_rate;
	}	  	
// Set the administering medication on the app
	public float setadministering_medication{		
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
// Dispays information on the app		
	au.print();
	au.show();
}
