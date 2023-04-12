interface IAccount{
    Date_of_opening:string;
    addCustomer():string;
    removeCustomer() : string;
}

class Account{
    Acc_no:number;
    Balance:number;

    constructor(acc_no = 1 , balance = 20){
        this.Acc_no = acc_no;
        this.Balance = balance;
    }

    debitAmount() : number{
        return 0;
    }
    creditAmount():number{
        return 0 ;
    }
    getBalance() : number{
        return this.Balance;
    }

}

class current_Account extends Account implements IAccount{
    Interset_rate:number;
    Date_of_opening: string;
    // customers:string[];
    addCustomer() :string{
        return `new customer Added in date ${this.Date_of_opening} in currentAccount`;
    }
    removeCustomer() :string{
        return `customer removed in currentAccount`;
    }
    

}

class Saving_Account extends Account implements IAccount{
    Min_Balance:number;
    Date_of_opening: string;
    addCustomer() : string{
        return `new customer Added in date ${this.Date_of_opening} in savingAccount`;
    }
    removeCustomer():string {
        return `customer removed in savingAccount`;
    }
    
}

var s = new Saving_Account();
s.Date_of_opening = '1/1/2001';
console.log(s.addCustomer());
console.log(s.removeCustomer());
var c = new current_Account();

var ac = new Account();
console.log(ac.creditAmount());