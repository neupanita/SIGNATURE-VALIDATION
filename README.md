
# SIGNATURE-VALIDATION


1	OVERVIEW
1.1	Project Description
The purpose of Signature Validation Application is to provide the end user with the ability to validate a set of hash results against various repositories. This is a standalone application which should be able to load the set of hash results and compare those results against user specified repository, containing multiple different sets of hash values. The set of results should always be displayed to the user and provide visual confirmation when the hash has been successfully validated or when the validation has failed.
2	PROJECT SCOPE
The following components and functionality should be included in the application.

2.1	Result Management
•	All results should be loaded and displayed to the user
•	User should be able to see the result file they have loaded in the application at all times.
•	Application should not allow for any of the results to be modified or deleted
•	User should be able to clear the results and load a different set of results
•	User should be able to export the final validation outcome to a csv file format
•	Application should clearly display to the user the final result once the validation process has finished 
	Optional the result could be displayed to the user after each record
2.2	Hash Validation Process
•	Validate above set of signatures against the provided hash repository
•	During the process of validation the application should be able to determine the type of signatures such as (SHA1, MD5, CRC16, CRC32, and HMACSHA1) and search the repository according the type of hash.



3	HIGH-LEVEL REQUIREMENTS
This section provides detailed description of all features required in the application. There are no specific requirements for the UI, however should be easy to use and with minimal amount of steps.

3.1.1	Result Management
The following features must be available to the user

•	Select and display result file
•	Display the file name and location
•	Display the content of the result file in a table format (table should set to read only at all times)
•	Select and display repository file
•	Initiate validation process
•	Display result final result

3.1.2	Hash Validation Process

•	Comparer settings
	Files and Folder names are case sensitive
	Leading/Trailing whitespaces should be removed from all values
	Leading/Trailing quotation marks should be accounted for in all values
	Hash values should not contain any white spaces
	Hash values should always be compared in UPPER case
•	Iterates through each result record
	The following information has to be interrogated to find a match

	If a match is found
The result row should be clearly identified based on the following table
MATCH	When all the criteria’s are met
NO MATCH	When the first two criteria’s are met but signature does not match
NO FILE	When the file does not exist in the repository






4	RESOURCES 
4.1	Resource Files
The result file lists each individual signature and signature type as a unique record as per 4.1.1, however all the data in the repository is grouped by file name with all hash values will the same line as per 4.1.2

4.1.1	HashResults.csv
 Represents a set of results to be validated with the following table format:

Column	Description
Location	Full path of the file or folder location, in case of logical drive the drive letter such as “F:\” is be replaced with “[root]:\”
FileFolderName	Actual name of the file or folder
SignatureType	Type of  hash signature (SHA1, MD5, CRC16, CRC32, HMAC-SHA1)
Signature	Hash value

4.1.2	HashRepository.csv
Represents multiple sets of result in the following table format:

Column	Description
imageName	Name of the file that was hashed
sigtype1	Represents signature type SHA1
sig1	Hash value for sigtype1
sigtype2	Represents signature type MD5
sig2	Hash value for sigtype2
sigtype3	Represents signature type CRC16
sig3	Hash value for sigtype3
sigtype4	Represents signature type CRC32
sig4	Hash value for sigtype4
sigtype5	Represents signature type HMACSHA1
sig5	Hash value for sigtype5

