const fs = require("fs");
const http = require("http");

http.createServer((req , res)=>{

    if(req.url != "/favicon.ico"){
        console.log(req.url);
        let splitArr = req.url.split('/');
        console.log(splitArr);
        let op = splitArr[1];
        console.log(op);

        let result = parseInt(splitArr[2]);
        console.log(result);

        //console.log(splitedArr); 

        switch(op){
            case "add":
                for(let i = 3; i < splitArr.length; i++){

                    result += parseInt(splitArr[i]);
                }
                break;

            case "sub":
                for(let i = 3; i < splitArr.length; i++){
                    result -= parseInt(splitArr[i]);
                }
                break;

            case "mul":
                for(let i = 3; i < splitArr.length; i++){
                    result *= parseInt(splitArr[i]);
                }
                break;

            case "div":
                for(let i = 3; i < splitArr.length; i++){
                    result /= parseInt(splitArr[i]);
                }
                break;

        }
        res.write(result.toString());
        fs.appendFileSync("output.txt" , `your result is : ${result.toString()}/n`);
        res.end();
    }
}).listen(7000)