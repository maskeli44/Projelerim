const update = require('../services/update')
const insert = require('../services/insert')
const updateTeacher = async function (req, res, next) {
    try {
        res.json(await update.updateTeacher(req.body,req.params.id));
    } catch (err) {
        console.error(`Error while updating Teacher`, err.message);
    }
}

const addTeacher = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addTeacher --data '{"registration_no":"111222333","firstname":"emily","lastname":"rose","position":"member","email":"emily@rose.com"}'
        res.json(await insert.addTeacher(req.body));
    } catch (err) {
        console.error(`Error while adding teacher`, err.message);
        next(err);
    }
}
module.exports = {
    updateTeacher,
    addTeacher
}