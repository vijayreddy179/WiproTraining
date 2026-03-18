const express = require('express');
const app=express();

app.get('/',(req,res) => {
    res.send('Welcome to backend server!!');
});

app.get('/api/data',(req,res) => {
    const products = [
        {id: 1, name: "Laptop", price: 65000},
        {id: 2, name: "Phone", price: 30000}
    ];
    res.json(products);
});

const PORT = process.env.PORT || 5000;
app.listen(PORT, () => {
    console.log('Server is running on port ${PORT}');
});