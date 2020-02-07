USE `test`;
DROP procedure IF EXISTS `invoicelinesInsert`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesInsert`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  invoiceId int (11),
  dateCreated timestamp ,
  unitPrice decimal ,
  multiplier int (11),
  showUnitPrice tinyint (4),
  showDate tinyint (4),
  OUT lid int
)
BEGIN
  INSERT INTO invoicelines(	
	code,
	description,
	info,
	invoiceId,
	dateCreated,
	unitPrice,
	multiplier,
	showUnitPrice,
	showDate,
	lastModified)
  VALUES(	
	code,
	description,
	info,
	invoiceId,
	dateCreated,
	unitPrice,
	multiplier,
	showUnitPrice,
	showDate,
	now());
  SET lid = last_insert_id();
END$$

DELIMITER ;