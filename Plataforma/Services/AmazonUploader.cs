﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Amazon.S3;
using Amazon.S3.Transfer;

namespace UploadToS3Demo
{
    public class AmazonUploader
    {
        public bool sendMyFileToS3(FileStream localFilePath, string bucketName, string subDirectoryInBucket, string fileNameInS3)
        {
            // input explained :
            // localFilePath = the full local file path e.g. "c:\mydir\mysubdir\myfilename.zip"
            // bucketName : the name of the bucket in S3 ,the bucket should be alreadt created
            // subDirectoryInBucket : if this string is not empty the file will be uploaded to
            // a subdirectory with this name
            // fileNameInS3 = the file name in the S3

            // create an instance of IAmazonS3 class ,in my case i choose RegionEndpoint.EUWest1
            // you can change that to APNortheast1 , APSoutheast1 , APSoutheast2 , CNNorth1
            // SAEast1 , USEast1 , USGovCloudWest1 , USWest1 , USWest2 . this choice will not
            // store your file in a different cloud storage but (i think) it differ in performance
            // depending on your location
            IAmazonS3 client = Amazon.AWSClientFactory.CreateAmazonS3Client("AKIAX2IFL5YNY7VQE6DW", "nIHA/CGh2Yp++9ko48qeegFkz3tpHFGWai6bfZDr", Amazon.RegionEndpoint.EUWest1);

            // create a TransferUtility instance passing it the IAmazonS3 created in the first step
            TransferUtility utility = new TransferUtility(client);
            // making a TransferUtilityUploadRequest instance
            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();

            if (subDirectoryInBucket == "" || subDirectoryInBucket == null)
            {
                request.BucketName = bucketName; //no subdirectory just bucket name
            }
            else
            {   // subdirectory and bucket name
                request.BucketName = bucketName + @"/" + subDirectoryInBucket;
            }
            request.Key = fileNameInS3; //file name up in S3
            //request.FilePath = @"C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\wwwroot\Uploads\" + localFilePath; //local file name
            request.CannedACL = S3CannedACL.PublicRead;
            request.InputStream = localFilePath;
            //commensing the transfer
            try
            {
                utility.Upload(request);
            }
            catch (Exception e)
            {
                return true;
            }
            return true; //indicate that the file was sent
        }
    }
}