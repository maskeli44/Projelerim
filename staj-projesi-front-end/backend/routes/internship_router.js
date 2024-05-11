const router = require('express').Router();
const internshipController = require('../controllers/internship_controller');
const errormiddleware = require('../middlewares/error_middleware');

router.post('/addInternship',internshipController.addInternship,errormiddleware.dbError);
router.put('/updateInternship/:id',internshipController.updateInternship,errormiddleware.dbError);
router.get('/acceptedInternship',internshipController.showAcceptedAppeals,errormiddleware.dbError);
router.get('/showInternshipInfo',internshipController.showInternshipInfo,errormiddleware.dbError);
router.get('/getStudentApplication/:id',internshipController.getStudentApplication,errormiddleware.dbError);
router.get('/getInternshipPeriod',internshipController.getInternshipPeriod,errormiddleware.dbError);

module.exports = router;