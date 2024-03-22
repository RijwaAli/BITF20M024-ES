pipeline {
    agent any
    tools { 
        maven 'Maven 3.9.6' 
    }
        
    stages {
        stage('Checkout SCM') {
            steps {
                echo 'Starting Checkout SCM stage...'
                checkout scm
            }
        }
        
        stage('Build') {
            steps {
                echo 'Starting Build stage...'
                echo 'This is a minimal pipeline.'
            }
        }
    }

    post {
        always {
            echo 'Pipeline execution completed'
        }
        
        success {
            // FindBugs plugin
            step([$class: 'FindBugsPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: ''])
            // PMD plugin
            step([$class: 'PmdPublisher', canComputeNew: false, defaultEncoding: '', excludePattern: '', healthy: '', unHealthy: '', useStableBuildAsReference: true])
        }
    
        failure {
            // Actions to perform if the pipeline fails
            echo 'Pipeline execution failed!'
            // You can add more actions here
        }
    }
}
