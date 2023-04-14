let {reservation} = require("../Modules/myModule");

let client3 = new reservation();
client3.AddTicket(3, 50 , 2300 ,"ioio" , '3/4/2021');

client3.AddTicket(4, 100 , 200 ,"yyy" , '5/5/2022');
// console.log(client1);
// console.log(client1);
// client1.AddTicket(1, 24 , 200 ,"gggg" , '1/1/2000' );

// let client2 = new myFlight.reservation();

// client1.AddTicket(2, 26 , 2000 ,"fijf" , '4/5/2020' );
client3.display();
client3.update(3 , 49 , 200 , "gff" , '3/3/2023');
client3.display();
client3.get(3);