
const { Console } = require("console");
const exp = require("express");
const app = exp();
let PORT = process.env.PORT || 7004;
const path = require("path");

const fs = require("fs");
let welcomeHtml = fs.readFileSync("../Client/welcome.html").toString();
let favIcon = fs.readFileSync("../Client/Icons/favicon.ico");
let styleCSS = fs.readFileSync("../Client/style.css").toString();

const bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({extended : true}));

let userName; 
let userMob ;
let userAdd ;
let userEmail;

app.get("/" , (req , res )=>{
    res.sendFile(path.join(__dirname , "../Client/main.html"));
})


app.post("/" , async(req , res)=>{
    var obj = req.body;
    console.log(obj);
    console.log(obj.usrName);
    await res.write(welcomeHtml.replace("{userName}" ,obj.usrName) .replace("{userMob}" , obj.usrMobile)
    .replace("{userAdd}" , obj.usrAddress).replace("{userEmail}" , obj.usrEmail)
    )
    // console.log(req.body);
    
})

app.listen(PORT , ()=>{console.log("http://localhost:"+PORT)})

//     

//         req.on("end" , ()=>{
//             res.write(welcomeHtml .replace("{userName}" , userName).replace("{userMob}" , userMob)
//             .replace("{userAdd}" , userAdd).replace("{userEmail}" , userEmail)
//             ) 
//             res.end();
//         })
//     }
// }).listen(7003 , ()=>{console.log("listining")})