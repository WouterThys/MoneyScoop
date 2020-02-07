USE `test`;
DROP procedure IF EXISTS `invoicesSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesSelectAll`()
BEGIN

	SELECT * FROM invoices;

END$$
DELIMITER ;