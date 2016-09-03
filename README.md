![](https://lithnet.github.io/images/logo-ex-small.png)
# Google Apps Management Agent for FIM 2010 R2 and MIM 2016
The Lithnet Google Apps Management Agent provides support for managing Google Apps users, groups and shared contacts with FIM 2010 R2 and higher.

## Features
* Supports the import and export of domain shared contact objects
* Supports the import and export of user objects
* Supports the import and export of group objects including group settings
* Supports the import of domains and aliases (read only)
* High performance import and export through the use of multithreading and batch updates
* Confirming (delta) import support for all object types

> Note: as most Google APIs do not provide delta support, this MA only confirms what was exported in a delta import. Changes made in Google Apps directly will not be seen until the next full import operation)


