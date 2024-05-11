const router = require('express').Router();
const studentController = require('../controllers/student_controller');
const errormiddleware = require('../middlewares/error_middleware');

router.post('/addStudent',studentController.addStudent,errormiddleware.dbError);
router.put('/updateStudent/:id',studentController.updateStudent,errormiddleware.dbError);
router.get('/student/:student_no',studentController.showStudent,errormiddleware.dbError);
router.get('/studentById/:id',studentController.showStudentById,errormiddleware.dbError);
module.exports = router;