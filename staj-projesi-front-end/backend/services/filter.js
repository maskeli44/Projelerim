const connection = require('../DB/connection');

async function getAcceptedAppeals() {
    
    const sql = `SELECT * FROM internship where commission_approval = 1`

    const result = await connection.session(sql);

    return result;

}


module.exports = {
    getAcceptedAppeals,
    
}