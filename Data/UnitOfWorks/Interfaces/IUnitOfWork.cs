﻿using Data.EntityRepositories.Interfaces;

namespace Data.UnitOfWorks.Interfaces;

public interface IUnitOfWork
{
    public IRoleRepository Role { get; }
    public IDepartmentRepository Department { get; }
    public IUserRepository User { get; }
    public IDocumentRepository Document { get; }
    public IDocumentStatusRepository DocumentStatus { get; }
    public IDocumentTypeRepository DocumentType { get; }
    public IProcessRepository Process { get; }
    public IProcessStepRepository ProcessStep { get; }
    void BeginTransaction();
    
    void Commit();
    
    void Rollback();
    
    void Dispose();
    
    Task<int> SaveChangesAsync();
}