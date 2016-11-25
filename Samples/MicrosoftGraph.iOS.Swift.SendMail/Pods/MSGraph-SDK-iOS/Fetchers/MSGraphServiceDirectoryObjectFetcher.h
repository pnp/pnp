/*******************************************************************************
**NOTE** This code was generated by a tool and will occasionally be
overwritten. We welcome comments and issues regarding this code; they will be
addressed in the generation tool. If you wish to submit pull requests, please
do so for the templates in that tool.

This code was generated by Vipr (https://github.com/microsoft/vipr) using
the T4TemplateWriter (https://github.com/msopentech/vipr-t4templatewriter).

Copyright (c) Microsoft Corporation. All Rights Reserved.
Licensed under the Apache License 2.0; see LICENSE in the source repository
root for authoritative license information.﻿
******************************************************************************/



#ifndef MSGRAPHSERVICEDIRECTORYOBJECTFETCHER_H
#define MSGRAPHSERVICEDIRECTORYOBJECTFETCHER_H

#import "MSGraphServiceModels.h"
#import "api/api.h"
#import "core/core.h"
#import "core/MSOrcEntityFetcher.h"

@class MSGraphServiceDeviceFetcher;	
@class MSGraphServiceDirectoryRoleFetcher;	
@class MSGraphServiceDirectoryRoleTemplateFetcher;	
@class MSGraphServiceGroupFetcher;	
@class MSGraphServiceOrganizationFetcher;	
@class MSGraphServiceUserFetcher;	
@class MSGraphServiceDirectoryObjectOperations;


/** MSGraphServiceDirectoryObjectFetcher
 *
 */
@interface MSGraphServiceDirectoryObjectFetcher : MSOrcEntityFetcher

@property (copy, nonatomic, readonly) MSGraphServiceDirectoryObjectOperations *operations;

- (instancetype)initWithUrl:(NSString*)urlComponent parent:(id<MSOrcExecutable>)parent;
- (void)readWithCallback:(void (^)(MSGraphServiceDirectoryObject *, MSOrcError *))callback;
- (void)update:(MSGraphServiceDirectoryObject *)directoryObject callback:(void (^)(MSGraphServiceDirectoryObject *, MSOrcError*))callback ;
- (void)delete:(void(^)(int status, MSOrcError *))callback;
- (MSGraphServiceDirectoryObjectFetcher *)addCustomParametersWithName:(NSString *)name value:(id)value;
- (MSGraphServiceDirectoryObjectFetcher *)addCustomHeaderWithName:(NSString *)name value:(NSString *)value;
- (MSGraphServiceDirectoryObjectFetcher *)select:(NSString *)params;
- (MSGraphServiceDirectoryObjectFetcher *)expand:(NSString *)value;
- (MSGraphServiceDeviceFetcher *)asDevice;	
- (MSGraphServiceDirectoryRoleFetcher *)asDirectoryRole;	
- (MSGraphServiceDirectoryRoleTemplateFetcher *)asDirectoryRoleTemplate;	
- (MSGraphServiceGroupFetcher *)asGroup;	
- (MSGraphServiceOrganizationFetcher *)asOrganization;	
- (MSGraphServiceUserFetcher *)asUser;	

@end

#endif
