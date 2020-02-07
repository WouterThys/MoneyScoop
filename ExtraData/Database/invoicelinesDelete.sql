USE `test`;
DROP procedure IF EXISTS `invoicelinesDelete`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesDelete`(
  deleteId int(11)
)
BEGIN
 DELETE FROM invoicelines WHERE id = deleteId;
END$$

DELIMITER ;