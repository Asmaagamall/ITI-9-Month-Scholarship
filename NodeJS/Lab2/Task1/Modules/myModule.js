
class reservation{
    flight = [];

    AddTicket(id , seatNum , flightNum , departure , travellingDate){
        const newReserv = {id , seatNum , flightNum , departure , travellingDate};
        this.flight.push(newReserv);
    }

    display() {
        for(let i = 0; i < this.flight.length;i++){
                console.log(`the client number ${this.flight[i].id} has seat Number ${this.flight[i].seatNum} , flight number ${this.flight[i].flightNum}
                 , departure ${this.flight[i].departure} and travelling date is ${this.flight[i].travellingDate}`)
        }
    }

    get(id){
        let isFound = false;
        for(let i = 0 ; i < this.flight.length; i++){
            if(id == this.flight[i].id){
                isFound = true;
                console.log(`the client number ${this.flight[i].id} has seat Number ${this.flight[i].seatNum} , flight number ${this.flight[i].flightNum}
                 , departure ${this.flight[i].departure} and travelling date is ${this.flight[i].travellingDate}`)
            }
            
        }
        if(isFound == false)
            console.log("not found");
    }

    update(id , seatNum , flightNum , departure , travellingDate){
        for(let i =0; i < this.flight.length; i++){
            if(id == this.flight[i].id){
                this.flight[i].seatNum = seatNum;
                this.flight[i].departure = departure;
                this.flight[i].flightNum = flightNum;
                this.flight[i].travellingDate = travellingDate;
                console.log("updated successfully");
            }
        }
    }
}

module.exports ={
    reservation
}