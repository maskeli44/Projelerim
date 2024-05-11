const express = require('express');
const app = express();
const dotenv = require('dotenv').config();
const ejs = require('ejs');
const expressLayouts = require('express-ejs-layouts');
const path = require('path');
const cors = require('cors')

app.set('view engine', 'ejs');
app.set('views', path.resolve(__dirname,'views'));
app.use(expressLayouts);
app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use(express.static('./assets'));
app.use(cors())




const homeRouter = require('./routes/home_router');
const studentRouter = require('./routes/student_router');
const teacherRouter = require('./routes/teacher_router');
const companyRouter = require('./routes/company_router');
const internshipRouter = require('./routes/internship_router');

app.use('/',homeRouter);
app.use('/',studentRouter);
app.use('/',teacherRouter);
app.use('/',companyRouter);
app.use('/',internshipRouter);

app.listen(process.env.PORT, () => {
    console.log("Running!!!");
});