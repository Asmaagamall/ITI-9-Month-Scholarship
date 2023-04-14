const http = require("http");
const fs = require("fs");

let mainHtml = fs.readFileSync("../Client/main.html").toString();
let welcomeHtml = fs.readFileSync("../Client/welcome.html").toString();
let favIcon = fs.readFileSync("../Client/Icons/favicon.ico");
let styleCSS = fs.readFileSync("../Client/style.css").toString();

let userName; 
let userMob ;
let userAdd ;
let userEmail;

http.createServer((req , res) =>{

    if(req.method == "GET"){
        console.log(req.url);
        switch(req.url){
            case '/':
            case '/main.html':
            case '/Client/main.html':
                res.write(mainHtml);
                break;

            case '/welcome.html':
            case '/Client/welcome.html':
                res.write(welcomeHtml);
                break;

            case '/style.css':
            case '/Client/style.css':
                res.write(styleCSS);

            case '/favicon.ico':
            case '/Client/Icons/favicon.ico':
                res.write(favIcon)
        }
        res.end();
    }

    else if(req.method == "POST"){
        req.on("data" , (data)=>{
            let AllData = data.toString().split('&');
             userName = AllData[0].split('=')[1];
             userMob = AllData[1].split('=')[1];
             userAdd = AllData[2].split('=')[1];
             userEmail = AllData[3].split('=')[1];
             console.log(userEmail);
             userEmail = userEmail.replace("%40" , "@");
             console.log(userEmail);

        })

        req.on("end" , ()=>{
            res.write(welcomeHtml .replace("{userName}" , userName).replace("{userMob}" , userMob)
            .replace("{userAdd}" , userAdd).replace("{userEmail}" , userEmail)
            ) 
            res.end();
        })
    }
}).listen(7003 , ()=>{console.log("listining")})