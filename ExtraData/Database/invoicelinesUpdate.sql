USE `test`;
DROP procedure IF EXISTS `invoicelinesUpdate`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesUpdate`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  invoiceId int (11),
  dateCreated timestamp ,
  unitPrice decimal ,
  multiplier int (11),
  showUnitPrice tinyint (4),
  showDate tinyint (4),
  updateId int
)
BEGIN
  UPDATE
	invoicelines
  SET	
	code = code,
	description = description,
	info = info,
	invoiceId = invoiceId,
	dateCreated = dateCreated,
	unitPrice = unitPrice,
	multiplier = multiplier,
	showUnitPrice = showUnitPrice,
	showDate = showDate,
	lastModified = current_timestamp()
  WHERE
	id = updateId;
END$$

DELIMITER ;