const router = require('express').Router();
const teacherController = require('../controllers/teacher_controller');
const errormiddleware = require('../middlewares/error_middleware');

router.put('/updateTeacher/:id',teacherController.updateTeacher,errormiddleware.dbError);
router.post('/addTeacher',teacherController.addTeacher,errormiddleware.dbError);


module.exports = router;