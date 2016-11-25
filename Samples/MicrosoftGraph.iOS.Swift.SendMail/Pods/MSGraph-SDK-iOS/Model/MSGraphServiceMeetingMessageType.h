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


#ifndef MSGRAPHSERVICEMEETINGMESSAGETYPE_H
#define MSGRAPHSERVICEMEETINGMESSAGETYPE_H

#import <Foundation/Foundation.h>

/** Enum MSGraphServiceMeetingMessageTypeEnum
 *
 */
typedef NS_ENUM(NSInteger, MSGraphServiceMeetingMessageType) {

    /** Enum entry MSGraphServiceMeetingMessageTypeNone
     * */
    MSGraphServiceMeetingMessageTypeNone,
    /** Enum entry MSGraphServiceMeetingMessageTypeMeetingRequest
     * */
    MSGraphServiceMeetingMessageTypeMeetingRequest,
    /** Enum entry MSGraphServiceMeetingMessageTypeMeetingCancelled
     * */
    MSGraphServiceMeetingMessageTypeMeetingCancelled,
    /** Enum entry MSGraphServiceMeetingMessageTypeMeetingAccepted
     * */
    MSGraphServiceMeetingMessageTypeMeetingAccepted,
    /** Enum entry MSGraphServiceMeetingMessageTypeMeetingTenativelyAccepted
     * */
    MSGraphServiceMeetingMessageTypeMeetingTenativelyAccepted,
    /** Enum entry MSGraphServiceMeetingMessageTypeMeetingDeclined
     * */
    MSGraphServiceMeetingMessageTypeMeetingDeclined
};


@interface MSGraphServiceMeetingMessageTypeSerializer : NSObject
+(MSGraphServiceMeetingMessageType) fromString:(NSString *) string;
+(NSString *) toString: (MSGraphServiceMeetingMessageType) value;
@end

#endif
