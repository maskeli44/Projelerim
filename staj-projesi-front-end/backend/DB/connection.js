const mysql = require('mysql2/promise');
const config = require('./config');



async function session(sql, input) {
    const connection = await mysql.createConnection(config.db);
    const [results,] = await connection.query(sql, input);
    return results;
}

module.exports = {
    session
}