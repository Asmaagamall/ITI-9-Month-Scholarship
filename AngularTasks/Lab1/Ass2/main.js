var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Account = /** @class */ (function () {
    function Account(acc_no, balance) {
        if (acc_no === void 0) { acc_no = 1; }
        if (balance === void 0) { balance = 20; }
        this.Acc_no = acc_no;
        this.Balance = balance;
    }
    Account.prototype.debitAmount = function () {
        return 0;
    };
    Account.prototype.creditAmount = function () {
        return 0;
    };
    Account.prototype.getBalance = function () {
        return this.Balance;
    };
    return Account;
}());
var current_Account = /** @class */ (function (_super) {
    __extends(current_Account, _super);
    function current_Account() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    // customers:string[];
    current_Account.prototype.addCustomer = function () {
        return "new customer Added in date ".concat(this.Date_of_opening, " in currentAccount");
    };
    current_Account.prototype.removeCustomer = function () {
        return "customer removed in currentAccount";
    };
    return current_Account;
}(Account));
var Saving_Account = /** @class */ (function (_super) {
    __extends(Saving_Account, _super);
    function Saving_Account() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Saving_Account.prototype.addCustomer = function () {
        return "new customer Added in date ".concat(this.Date_of_opening, " in savingAccount");
    };
    Saving_Account.prototype.removeCustomer = function () {
        return "customer removed in savingAccount";
    };
    return Saving_Account;
}(Account));
var s = new Saving_Account();
s.Date_of_opening = '1/1/2001';
console.log(s.addCustomer());
console.log(s.removeCustomer());
var c = new current_Account();
var ac = new Account();
console.log(ac.creditAmount());
