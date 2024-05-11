const db = require('../DB/connection')

async function updateStudent(student,id){

    const input = [student.student_no,student.firstname,student.lastname,student.tc_no,student.phone_no,student.email,student.address,student.nation,id];

    const sqlQuery = `UPDATE student SET 
    student_no = ?,
    firstname = ?,
    lastname = ?,
    tc_no = ?,
    phone_no = ?,
    email = ?,
    address = ?,
    nation = ?
    WHERE id = ?
    `
    const result = await db.session(sqlQuery, input)

    let message = 'Updating student has faild';

    if (result.affectedRows) {
        message = 'Updating student successfully';
    }

    return { message };
}

async function updateTeacher(teacher,id){

    const input = [teacher.registration_no,teacher.firstname,teacher.lastname,teacher.position,teacher.email,id];

    const sqlQuery = `UPDATE teacher SET 
    registration_no = ?,
    firstname = ?,
    lastname = ?,
    position = ?,
    email = ?
    WHERE id = ?
    `

    const result = await db.session(sqlQuery, input)

    let message = 'Updating teacher has faild';

    if (result.affectedRows) {
        message = 'teacher Updated successfully';
    }

    return { message };
}


async function updateCompany(company,id){
    const input = [company.name,company.sector,company.tax_number,company.phone_no,company.email,company.web_address,company.address,id];

    const sqlQuery = `UPDATE company SET
    company_name = ?, 
    sector = ?,
    tax_number = ?,
    phone_no = ?,
    email = ?,
    web_address = ?,
    address = ?
    WHERE id = ?
    `

    const result = await db.session(sqlQuery, input)

    let message = 'Updating company has faild';

    if (result.affectedRows) {
        message = 'company Updated successfully';
    }

    return { message };
}

async function updateInternship(internship, id){
    
    internship.student_id = parseInt(internship.student_id);
    internship.company_id = parseInt(internship.company_id);
    internship.number_of_days = parseInt(internship.number_of_days);
    internship.commission_head_id = parseInt(internship.commission_head_id);
    internship.commission_member1_id = parseInt(internship.commission_member1_id);
    internship.commission_member2_id = parseInt(internship.commission_member2_id);
    internship.accepted_number_of_days = parseInt(internship.accepted_number_of_days);
    internship.commission_approval = parseInt(internship.commission_approval);
    //console.log(internship);
    const input = [internship.student_id,internship.company_id,internship.start_date,internship.end_date,
        internship.number_of_days,internship.chief,internship.subject,internship.appeal_form,internship.commission_head_id,internship.commission_member1_id,
        internship.commission_member2_id,internship.internship_book,internship.accepted_number_of_days,internship.commission_approval,internship.commission_accepted_appeal_form,internship.department, internship.engineers_number ,id];    
    const sqlQuery = `UPDATE internship SET 
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
    WHERE id = ?
    `

    const result = await db.session(sqlQuery, input)

    let message = 'Updating internship has faild';

    if (result.affectedRows) {
        message = 'internship Updated successfully';
    }

    return { message };
}

module.exports = {
    updateStudent,
    updateTeacher,
    updateInternship,
    updateCompany
}