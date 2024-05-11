const connection = require('../DB/connection');


async function addStudent(student) {

    const input = [student.student_no,student.firstname,student.lastname,student.tc_no,student.phone_no,student.email,student.address,student.nation];

    const sql = `INSERT INTO student 
    (
        student_no,
        firstname,
        lastname,
        tc_no,
        phone_no,
        email,
        address,
        nation
    ) VALUES
    (
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?
    )`

    const result = await connection.session(sql, input)

    let message = 'Error in adding student';

    if (result.affectedRows) {
        message = 'student added successfully';
    }

    return { message };

}

async function addTeacher(teacher) {

    const input = [teacher.registration_no,teacher.firstname,teacher.lastname,teacher.position,teacher.email];

    const sql = `INSERT INTO teacher 
    (
        registration_no,
        firstname,
        lastname,
        position,
        email
    ) VALUES
    (
        ?,
        ?,
        ?,
        ?,
        ?
    )`

    const result = await connection.session(sql, input)

    let message = 'Error in adding teacher';

    if (result.affectedRows) {
        message = 'teacher added successfully';
    }

    return { message };

}

async function addCompany(company) {

    const input = [company.company_name,company.sector,company.tax_number,company.phone_no,company.email,company.web_address,company.address];

    const sql = `INSERT INTO company 
    (
        company_name,
        sector,
        tax_number,
        phone_no,
        email,
        web_address,
        address
    ) VALUES
    (
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?
    )`

    const result = await connection.session(sql, input)

    let message = 'Error in adding company';

    if (result.affectedRows) {
        message = 'company added successfully';
    }

    return { message };

}

async function addInternship(internship) {
    //yyyy-mm-dd

    const input = [internship.student_id,internship.company_id,internship.start_date,internship.end_date,internship.number_of_days,internship.chief,internship.subject,internship.appeal_form,internship.commission_head_id,internship.commission_member1_id,internship.commission_member2_id,internship.internship_book,internship.accepted_number_of_days,internship.commission_approval,internship.commission_accepted_appeal_form, internship.department, internship.engineers_number];    
    
    internship.student_id = parseInt(internship.student_id);
    internship.company_id = parseInt(internship.company_id);
    internship.number_of_days = parseInt(internship.number_of_days);
    internship.commission_head_id = parseInt(internship.commission_head_id);
    internship.commission_member1_id = parseInt(internship.commission_member1_id);
    internship.commission_member2_id = parseInt(internship.commission_member2_id);
    internship.accepted_number_of_days = parseInt(internship.accepted_number_of_days);
    internship.commission_approval = parseInt(internship.commission_approval);
    //yyyy-mm-dd

    const sql = `INSERT INTO internship 
    (
        student_id,
        company_id,
        start_date,
        end_date,
        number_of_days,
        chief,
        subject,
        appeal_form,
        commission_head_id,
        commission_member1_id,
        commission_member2_id,
        internship_book,
        accepted_number_of_days,
        commission_approval,
        commission_accepted_appeal_form,
        department,
        engineers_number
    ) VALUES
    (
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?,
        ?

    )`

    const result = await connection.session(sql, input)

    let message = 'Error in adding internship';

    if (result.affectedRows) {
        message = 'internship added successfully';
    }

    return { message };

}



module.exports = {
    addStudent,
    addTeacher,
    addCompany,
    addInternship
}