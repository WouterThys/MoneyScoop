USE `test`;
DROP procedure IF EXISTS `invoicelinesSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesSelectAll`()
BEGIN

	SELECT * FROM invoicelines;

END$$
DELIMITER ;