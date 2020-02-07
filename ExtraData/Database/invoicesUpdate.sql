USE `test`;
DROP procedure IF EXISTS `invoicesUpdate`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesUpdate`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  dateCreated timestamp ,
  dateSend timestamp ,
  datePayed timestamp ,
  vat int (11),
  customerId int (11),
  updateId int
)
BEGIN
  UPDATE
	invoices
  SET	
	code = code,
	description = description,
	info = info,
	dateCreated = dateCreated,
	dateSend = dateSend,
	datePayed = datePayed,
	vat = vat,
	customerId = customerId,
	lastModified = current_timestamp()
  WHERE
	id = updateId;
END$$

DELIMITER ;