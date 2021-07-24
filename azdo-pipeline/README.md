Pipeline
===

This directory contains [Azure DevOps Pipeline](https://docs.microsoft.com/en-us/azure/devops/pipelines/) definitions for the 
CICD-Example service.

- [build.yaml](build.yaml) contains the main build/deployment definition.
- [build-gated.yaml](build-gated.yaml) contains the gated build definition, which runs as part of the pull request process.
- [deploy.yaml](deploy.yaml) contains tasks to deploy to an environment
- [parse-json-configuration.yaml](parse-json-configuration.yaml) contains code to read and parse json for use in subsequent pipeline steps
- [unified-build-deployment.yaml](unified-build-deployment.yaml) contains values per environment