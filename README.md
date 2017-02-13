# Helix Base - _work in progress, completion date: by 17/02/2017_
A Sitecore Helix based solution which can be used for greenfield projects.

#### Features include:

* Glass Mapper
* Unicorn
* Sitecore 8.2 Update-2 ready
* Target .net framework 4.5.2 for backwards compatibility
* Microsoft Dependency Injection
* A sample hero banner feature and sample site project for demonstration
* Pre configured generic item repository

#### Coming soon:

* User and role Unicorn sync
* Unicorn remote module
* Generic repository for search API

## Setup Instructions
1. Install Sitecore Experience Platform 8.2 rev. 161221 (8.2 Update-2) **Name your instance 'Helixbase'
2. Clone project to 'C:\Projects\Helix base' **if you use another path update the 'z.Helixbase.Settings.config' file and the 'gulp-config.js'
3. Install node.js and run 'npm-install' in the project root
4. Publish each project or use the 'Publish-All-Projects' task in your task runner
5. Run the Unicorn sync in your browser
