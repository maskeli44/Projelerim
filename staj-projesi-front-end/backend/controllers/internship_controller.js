const insert = require('../services/insert')
const update = require('../services/update')
const filter = require('../services/filter');
const list = require('../services/list');

const addInternship = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await insert.addInternship(req.body));
    } catch (err) {
        console.error(`Error while adding internship`, err.message);
        next(err);
    }
}

const updateInternship = async function (req, res, next) {
    try {
        //curl -X PUT -H 'Content-Type: application/json' -i http://localhost:3000/updateInternship/3 --data '{"student_id":"3","department_id":"2","company_id":"3","field_id":"2","start_date":"1999-08-08","end_date":"2000-09-09","number_of_days":"3","chief":"1","subject":"software","appeal_form":"../uploads/form","commission_head_id":"1","commission_number1_id":"2","commission_number2_id":"3","internship_book":"../uploads/books","accepted_number_of_days":"23","commission_approval":"0","commission_accepted_appeal_form":"../uploads/accepted_forms"}'
        //console.log(req.body);
        res.json(await update.updateInternship(req.body, req.params.id));
    } catch (err) {
        console.error(`Error while updating internship`, err.message);
        next(err);
    }
}

const showAcceptedAppeals = async function (req, res, next) {
    try {
        //curl -X PUT -H 'Content-Type: application/json' -i http://localhost:3000/updateInternship/3 --data '{"student_id":"3","department_id":"2","company_id":"3","field_id":"2","start_date":"1999-08-08","end_date":"2000-09-09","number_of_days":"3","chief":"1","subject":"software","appeal_form":"../uploads/form","commission_head_id":"1","commission_number1_id":"2","commission_number2_id":"3","internship_book":"../uploads/books","accepted_number_of_days":"23","commission_approval":"0","commission_accepted_appeal_form":"../uploads/accepted_forms"}'
        res.json(await filter.getAcceptedAppeals());
    } catch (err) {
        console.error(`Error while retrieving accepted appeals`, err.message);
        next(err);
    }
}

const showInternshipInfo = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await list.getInternshipInfo());
    } catch (err) {
        console.error(`Error while retrieving all application data!`, err.message);
        next(err);
    }
}

const getStudentApplication = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await list.getStudentApplication(req.params.id));
    } catch (err) {
        console.error(`Error while retrieving student application data!`, err.message);
        next(err);
    }
}

const getInternshipPeriod = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await list.getInternshipPeriod());
    } catch (err) {
        console.error(`Error while retrieving internship period!`, err.message);
        next(err);
    }
}

module.exports = {
    addInternship,
    updateInternship,
    showAcceptedAppeals,
    showInternshipInfo,
    getStudentApplication,
    getInternshipPeriod
}