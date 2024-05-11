const insert = require('../services/insert')
const update = require('../services/update')
const list = require('../services/list');
const addStudent = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await insert.addStudent(req.body));
    } catch (err) {
        console.error(`Error while adding student`, err.message);
        next(err);
    }
}

const updateStudent = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addStudent --data '{"student_no":"309111222","firstname":"alex","lastname":"white","tc_no":"66622233444","phone_no":"05443332288","email":"alex@white.com","address":"london","nation":"england"}'
        res.json(await update.updateStudent(req.body, req.params.id));
    } catch (err) {
        console.error(`Error while updating student`, err.message);
        next(err);
    }
}

const showStudent = async function (req, res, next) {
    try {
        res.json(await list.getStudent(req.params.student_no));
    } catch (err) {
        console.error(`Error while showing student`, err.message);
        next(err);
    }
}

const showStudentById = async function (req, res, next) {
    try {
        res.json(await list.getStudentById(req.params.id));
    } catch (err) {
        console.error(`Error while showing student via id`, err.message);
        next(err);
    }
}

module.exports = {
    addStudent,
    updateStudent,
    showStudent,
    showStudentById
}