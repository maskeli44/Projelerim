const insert = require('../services/insert');
const update = require('../services/update');
const list = require('../services/list');

const addCompany = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addCompany --data '{"sector":"vodafone","tax_number":"222233","phone_no":"05423654345","web_address":"http://vodafone.com","email":"vodafone@istanbul.com","address":"istanbul"}'
        res.json(await insert.addCompany(req.body));
    } catch (err) {
        console.error(`Error while adding company`, err.message);
        next(err);
    }
}

const updateCompany = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addCompany --data '{"sector":"vodafone","tax_number":"222233","phone_no":"05423654345","web_address":"http://vodafone.com","email":"vodafone@istanbul.com","address":"istanbul"}'
        res.json(await update.updateCompany(req.body, req.params.id));
    } catch (err) {
        console.error(`Error while updating company record`, err.message);
        next(err);
    }
}

const showCompany = async function (req, res, next) {
    try {
        //curl -X POST -H 'Content-Type: application/json' -i http://localhost:3000/addCompany --data '{"sector":"vodafone","tax_number":"222233","phone_no":"05423654345","web_address":"http://vodafone.com","email":"vodafone@istanbul.com","address":"istanbul"}'
        res.json(await list.getCompany());
    } catch (err) {
        console.error(`Error while retriving company`, err.message);
        next(err);
    }
}

module.exports = {
    addCompany,
    updateCompany,
    showCompany
}