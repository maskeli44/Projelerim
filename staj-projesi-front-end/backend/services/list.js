const connection = require('../DB/connection');

async function getInternshipInfo(){
    const sqlQuery = `SELECT inter.id AS application_no, student_no, concat(st.firstname,' ',st.lastname) AS studentName,start_date,end_date ,number_of_days, chief, subject, accepted_number_of_days, internship_book,concat(t.firstname, ' ', t.lastname) AS teacherName, commission_approval, commission_accepted_appeal_form,company_name FROM student st join internship inter on st.id = inter.student_id join teacher as t on inter.commission_head_id = t.id join company co on inter.company_id = co.id`

    const result = await connection.session(sqlQuery);

    return result;
}


async function getStudent(student_no) {
    const input = student_no;
    const sqlQuery = `SELECT * FROM student where student_no =?`;
    const result = await connection.session(sqlQuery, [input]);
    return result;
}

async function getStudentById(id) {
    
    const sqlQuery = `SELECT * FROM student where id =?`;
    const result = await connection.session(sqlQuery, [id]);
    return result;
}

async function getCompany() {
    
    const sqlQuery = `SELECT * FROM company`;
    const result = await connection.session(sqlQuery);
    return result;
}

async function getStudentApplication(id) {
    const input = id;
    const sqlQuery = `SELECT inter.id AS application_no, student_no, concat(st.firstname,' ',st.lastname) AS studentName,start_date,end_date ,number_of_days, chief, subject, accepted_number_of_days, internship_book,concat(t.firstname, ' ', t.lastname) AS teacherName, commission_approval, commission_accepted_appeal_form,company_name FROM student st join internship inter on st.id = inter.student_id join teacher as t on inter.commission_head_id = t.id join company co on inter.company_id = co.id where st.id = ?`;
    const result = await connection.session(sqlQuery, [input]);
    return result;
}

async function getInternshipPeriod() {
    
    const sqlQuery = `SELECT * FROM internship_period`;
    const result = await connection.session(sqlQuery);
    return result;
}

module.exports = {
    getStudentApplication,
    getInternshipInfo,
    getStudent,
    getCompany,
    getInternshipPeriod,
    getStudentById
}