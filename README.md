# Service Locator
A simple implementation of the service locator pattern. It is accessable through the static 'ServiceLocator' class, 
which is used both for registering via the 'ServiceRegistrar' class and getting services by type. The registrar supports services by an instance, by singleton,
by method, by factory and as transient. Which can be intuitively created with the registrar.
