const express= require('express');
const app=express();
const dotenv=require('dotenv').config();

app.use(express.json())
app.use(express.urlencoded({ extended: true }))

app.get('/',(req,res)=> {
    res.send('Bu API Bimser Yaz Staji için geliştirilmiştir.');
} );

app.listen(process.env.PORT,()=>console.log('Server is Listening..'));