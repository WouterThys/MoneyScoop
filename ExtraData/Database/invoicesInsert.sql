USE `test`;
DROP procedure IF EXISTS `invoicesInsert`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesInsert`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  dateCreated timestamp ,
  dateSend timestamp ,
  datePayed timestamp ,
  vat int (11),
  customerId int (11),
  OUT lid int
)
BEGIN
  INSERT INTO invoices(	
	code,
	description,
	info,
	dateCreated,
	dateSend,
	datePayed,
	vat,
	customerId,
	lastModified)
  VALUES(	
	code,
	description,
	info,
	dateCreated,
	dateSend,
	datePayed,
	vat,
	customerId,
	now());
  SET lid = last_insert_id();
END$$

DELIMITER ;